using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ProcessWindowInfo
{
    public partial class Form1 : Form
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int x, y;
        }
        
        [StructLayout(LayoutKind.Sequential)]
        public struct WINDOWPLACEMENT
        {
            public int length;
            public int flags;
            public int showCmd;
            public POINT ptMinPosition;
            public POINT ptMaxPosition;
            public RECT rcNormalPosition;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left, top, right, bottom;
        }

        [DllImport("user32.dll")]
        private static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out int processId);

        [DllImport("user32.dll")]
        private static extern IntPtr GetParent(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool IsIconic(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern bool IsWindowEnabled(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport("dwmapi.dll")]
        private static extern int DwmGetWindowAttribute(IntPtr hWnd, int dwAttribute, out int pvAttribute, int cbAttribute);

        [DllImport("user32.dll")]
        public static extern bool GetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("user32.dll")]
        static extern bool MoveWindow(IntPtr hWnd, int x, int y, int nWidth, int nHeight, bool bRepaint);

        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_TOOLWINDOW = 0x00000080;
        private const int DWMWA_CLOAKED = 14;
        private delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        private const int SW_RESTORE = 9;
        private const int SW_SHOWMINIMIZED = 2;
        private const int SW_SHOWMAXIMIZED = 3;
        private Timer timer;

        public Form1()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        { 
            btnRefresh.PerformClick();

            timer.Stop();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lstProcesses.Items.Clear();
            Dictionary<IntPtr, string> windowDict = new Dictionary<IntPtr, string>(); // 창 핸들 기반 중복 제거

            EnumWindows((hWnd, lParam) =>
            {
                if (!IsWindowVisible(hWnd) || GetParent(hWnd) != IntPtr.Zero) return true; // 숨겨진 창 제외

                int exStyle = GetWindowLong(hWnd, GWL_EXSTYLE);
                if ((exStyle & WS_EX_TOOLWINDOW) != 0) return true; // 툴 창 제외

                int cloaked;
                if (DwmGetWindowAttribute(hWnd, DWMWA_CLOAKED, out cloaked, sizeof(int)) == 0 && cloaked != 0) return true; // 숨겨진 창 제외

                StringBuilder className = new StringBuilder(256);
                GetClassName(hWnd, className, className.Capacity);
                if (className.ToString() == "ApplicationFrameWindow" || className.ToString() == "Windows.UI.Core.CoreWindow") return true; // 시스템 창 제외

                StringBuilder windowText = new StringBuilder(256);
                GetWindowText(hWnd, windowText, 256);
                if (windowText.Length > 0)
                {
                    GetWindowThreadProcessId(hWnd, out int processId);
                    try
                    {
                        Process process = Process.GetProcessById(processId);
                        //string displayText = $"{process.ProcessName} - {windowText}";
                        string displayText = $"{windowText}";
                        windowDict[hWnd] = displayText; // 창 핸들 기준으로 저장
                    }
                    catch { }
                }
                return true;
            }, IntPtr.Zero);

            lstProcesses.DisplayMember = "Value";
            foreach (var entry in windowDict)
            {
                lstProcesses.Items.Add(entry);
            }
        }

        private void btnCascade_Click(object sender, EventArgs e)
        {
            int first = 0;
            int second = 0;

            for (int i = lstProcesses.Items.Count - 1; i >- 0; i--)
            {
                var item = lstProcesses.Items[i];

                if (item is KeyValuePair<IntPtr, string> pair)
                {
                    WINDOWPLACEMENT placement = new WINDOWPLACEMENT();
                    placement.length = Marshal.SizeOf(typeof(WINDOWPLACEMENT));

                    if (GetWindowPlacement(pair.Key, ref placement))
                    {
                        // 최소화 또는 최대화된 창을 리스토어
                        if (placement.showCmd == SW_SHOWMINIMIZED)
                        {
                            //ShowWindow(pair.Key, SW_RESTORE);
                        }
                    //}
                    //if (GetWindowPlacement(pair.Key, ref placement))
                    //{
                        // 최소화 또는 최대화된 창을 리스토어
                        if (placement.showCmd == SW_SHOWMAXIMIZED)
                        {
                            ShowWindow(pair.Key, SW_RESTORE);
                        }
                    }

                    // 창의 위치와 크기 가져오기
                    if (GetWindowRect(pair.Key, out RECT rect))
                    {
                        int x = rect.left;
                        //int y = rect.top;
                        //int width = rect.right - rect.left;
                        //int height = rect.bottom - rect.top;

                        if (x < 1920)
                        {
                            MoveWindow(pair.Key, 30 * first, 30 * first, 1280, 720, true);
                            first++;
                            if (first > 10)
                            {
                                first = 0;
                            }
                        }
                        else
                        {
                            MoveWindow(pair.Key, 1920 + 30 * second, 30 * second, 1280, 720, true);
                            second++;
                            if (second > 10)
                            {
                                second = 0;
                            }
                        }
                    }
                }
            }

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem is KeyValuePair<IntPtr, string> selectedPair)
            {
                MoveWindow(selectedPair.Key, 0, 0, 3840, 1040, true);
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem is KeyValuePair<IntPtr, string> selectedPair)
            {
                MoveWindow(selectedPair.Key, 0, 0, 1920, 1040, true);
            }
        }

        private void btnSecond_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem is KeyValuePair<IntPtr, string> selectedPair)
            {
                MoveWindow(selectedPair.Key, 1920, 0, 1920, 1040, true);
            }
        }

        private void btnFirst1stHalf_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem is KeyValuePair<IntPtr, string> selectedPair)
            {
                MoveWindow(selectedPair.Key, 0, 0, 960, 1040, true);
            }
        }

        private void btnFirst2ndHalf_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem is KeyValuePair<IntPtr, string> selectedPair)
            {
                MoveWindow(selectedPair.Key, 960, 0, 960, 1040, true);
            }
        }

        private void btnSecond1stHalf_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem is KeyValuePair<IntPtr, string> selectedPair)
            {
                MoveWindow(selectedPair.Key, 1920, 0, 960, 1040, true);
            }
        }

        private void btnSecond2ndHalf_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem is KeyValuePair<IntPtr, string> selectedPair)
            {
                MoveWindow(selectedPair.Key, 2880, 0, 960, 1040, true);
            }
        }

        private void First1stThird_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem is KeyValuePair<IntPtr, string> selectedPair)
            {
                MoveWindow(selectedPair.Key, 0, 0, 640, 1040, true);
            }
        }

        private void First2ndThird_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem is KeyValuePair<IntPtr, string> selectedPair)
            {
                MoveWindow(selectedPair.Key, 640, 0, 640, 1040, true);
            }
        }

        private void First3rdThird_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem is KeyValuePair<IntPtr, string> selectedPair)
            {
                MoveWindow(selectedPair.Key, 1280, 0, 640, 1040, true);
            }
        }

        private void Second1stThird_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem is KeyValuePair<IntPtr, string> selectedPair)
            {
                MoveWindow(selectedPair.Key, 1920, 0, 640, 1040, true);
            }
        }

        private void Second2ndThird_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem is KeyValuePair<IntPtr, string> selectedPair)
            {
                MoveWindow(selectedPair.Key, 2560, 0, 640, 1040, true);
            }
        }

        private void Second3rdThird_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem is KeyValuePair<IntPtr, string> selectedPair)
            {
                MoveWindow(selectedPair.Key, 3200, 0, 640, 1040, true);
            }
        }

        private void First1stDouble_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem is KeyValuePair<IntPtr, string> selectedPair)
            {
                MoveWindow(selectedPair.Key, 0, 0, 1280, 1040, true);
            }
        }

        private void First2ndDouble_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem is KeyValuePair<IntPtr, string> selectedPair)
            {
                MoveWindow(selectedPair.Key, 640, 0, 1280, 1040, true);
            }
        }

        private void Second1stDouble_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem is KeyValuePair<IntPtr, string> selectedPair)
            {
                MoveWindow(selectedPair.Key, 1920, 0, 1280, 1040, true);
            }
        }

        private void Second2ndDouble_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem is KeyValuePair<IntPtr, string> selectedPair)
            {
                MoveWindow(selectedPair.Key, 2560, 0, 1280, 1040, true);
            }
        }

        private void First1stQuarter_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem is KeyValuePair<IntPtr, string> selectedPair)
            {
                MoveWindow(selectedPair.Key, 0, 0, 480, 1040, true);
            }
        }

        private void First2ndQuarter_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem is KeyValuePair<IntPtr, string> selectedPair)
            {
                MoveWindow(selectedPair.Key, 480, 0, 480, 1040, true);
            }
        }

        private void First3rdQuarter_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem is KeyValuePair<IntPtr, string> selectedPair)
            {
                MoveWindow(selectedPair.Key, 960, 0, 480, 1040, true);
            }
        }

        private void First4thQuarter_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem is KeyValuePair<IntPtr, string> selectedPair)
            {
                MoveWindow(selectedPair.Key, 1440, 0, 480, 1040, true);
            }
        }

        private void Second1stQuarter_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem is KeyValuePair<IntPtr, string> selectedPair)
            {
                MoveWindow(selectedPair.Key, 1920, 0, 480, 1040, true);
            }
        }

        private void Second2ndQuarter_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem is KeyValuePair<IntPtr, string> selectedPair)
            {
                MoveWindow(selectedPair.Key, 2400, 0, 480, 1040, true);
            }
        }

        private void Second3rdQuarter_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem is KeyValuePair<IntPtr, string> selectedPair)
            {
                MoveWindow(selectedPair.Key, 2880, 0, 480, 1040, true);
            }
        }

        private void Second4thQuarter_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem is KeyValuePair<IntPtr, string> selectedPair)
            {
                MoveWindow(selectedPair.Key, 3360, 0, 480, 1040, true);
            }
        }
    }
}

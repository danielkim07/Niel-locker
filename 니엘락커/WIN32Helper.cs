using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace 니엘락커
{
    internal class WIN32Helper
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////// Import
        ////////////////////////////////////////////////////////////////////////////////////////// Static
        //////////////////////////////////////////////////////////////////////////////// Private

        #region 윈도우 찾기 - FindWindow(className, windowText)

        /// <summary>
        /// 윈도우 찾기
        /// </summary>
        /// <param name="className">클래스명</param>
        /// <param name="windowText">윈도우 텍스트</param>
        /// <returns>윈도우 핸들</returns>
        [DllImport("user32.dll")]
        private static extern int FindWindow(string className, string windowText);

        #endregion
        #region 윈도우 표시하기 - ShowWindow(windowHandle, command)

        /// <summary>
        /// 윈도우 표시하기
        /// </summary>
        /// <param name="windowHandle">윈도우 핸들</param>
        /// <param name="command">명령</param>
        /// <returns>처리 결과</returns>
        [DllImport("user32.dll")]
        private static extern int ShowWindow(int windowHandle, int command);

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Field
        ////////////////////////////////////////////////////////////////////////////////////////// Instance

        #region Field

        /// <summary>
        /// SW_HIDE
        /// </summary>
        private const int SW_HIDE = 0;

        /// <summary>
        /// SW_SHOW
        /// </summary>
        private const int SW_SHOW = 1;

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Method
        ////////////////////////////////////////////////////////////////////////////////////////// Static
        //////////////////////////////////////////////////////////////////////////////// Public

        #region 작업 표시줄 숨기기 - HideTaskbar()

        /// <summary>
        /// 작업 표시줄 숨기기
        /// </summary>
        public static void HideTaskbar()
        {
            int hwnd = FindWindow("Shell_TrayWnd", "");

            ShowWindow(hwnd, SW_HIDE);
        }

        #endregion
        #region 작업 표시줄 표시하기 - ShowTaskbar()

        /// <summary>
        /// 작업 표시줄 표시하기
        /// </summary>
        public static void ShowTaskbar()
        {
            int windowHandle = FindWindow("Shell_TrayWnd", string.Empty);

            ShowWindow(windowHandle, SW_SHOW);
        }

        #endregion
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace pc_ekranı
{
    class tskbar
    {
       [DllImport("user32.dll")]
       private static extern int FindWindow(string className, string windowText);

       [DllImport("user32.dll")]
       private static extern int ShowWindow(int hwnd, int command);

       [DllImport("user32.dll")]
       public static extern int FindWindowEx(int parentHandle, int childAfter, string className, int windowTitle);

       [DllImport("user32.dll")]
       private static extern int GetDesktopWindow();

       private const int SW_HIDE = 0;
       private const int SW_SHOW = 1;

       protected static int Handle
       {
           get
           {
               return FindWindow("Shell_TrayWnd", "");
           }
       }

       protected static int HandleOfStartButton
       {
           get
           {
               int handleOfDesktop = GetDesktopWindow();
               int handleOfStartButton = FindWindowEx(handleOfDesktop, 0, "button", 0);
               return handleOfStartButton;
           }
       }

       public static void Goster()
       {
           ShowWindow(Handle, SW_SHOW);
           ShowWindow(HandleOfStartButton, SW_SHOW);
       }

       public static void Gizle()
       {
           ShowWindow(Handle, SW_HIDE);
           ShowWindow(HandleOfStartButton, SW_HIDE);
       }
   }

    }


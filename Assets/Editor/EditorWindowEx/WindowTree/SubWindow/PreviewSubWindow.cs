﻿using System;
using UnityEngine;
using System.Collections;
using System.Reflection;
using EditorWinEx;

/// <summary>
/// Preview风格子窗体
/// </summary>
[SubWindowStyle(SubWindowStyle.Preview)]
public class PreviewSubWindow : SubWindow
{

    public PreviewSubWindow(string title, string icon, bool defaultOpen, MethodInfo method, System.Object target, EWSubWindowToolbarType toolbar, SubWindowHelpBoxType helpbox)
        : base(title, icon, defaultOpen, method, target, toolbar, helpbox)
    {
    }

    protected override Rect DrawMainArea(Rect rect)
    {
        GUI.Box(rect, string.Empty, GUIStyleCache.GetStyle("GameViewBackground"));

        return rect;
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class UninstallCheck : MonoBehaviour
{
    public GameObject LaunchOptions;
    public GameObject UninstallButton;
    public GameObject InstalledVerText;
    public Button GameFilesButton;
    public Button InstallIPAButton;
    public static UninstallCheck instance;
    public static bool showLaunchOptions = false;
    public void Start()
    {
        instance = this;
    }

    public static void DoUninstallCheck(bool autoShow = false)
    {
        showLaunchOptions = false;
        if (File.Exists(InstalledVersionToggle.BSDirectory + "Beat Saber.exe"))
        {
            showLaunchOptions = true;
            instance.LaunchOptions.SetActive(false);
            instance.InstalledVerText.SetActive(false);
            instance.InstallIPAButton.interactable = true;
            instance.GameFilesButton.interactable = true;
            instance.UninstallButton.SetActive(true);
        } else
        {
            instance.LaunchOptions.SetActive(false);
            instance.InstalledVerText.SetActive(false);
        }
        if(autoShow) ShowLaunchOptions();
    }

    public static void ShowLaunchOptions()
    {
        instance.LaunchOptions.SetActive(showLaunchOptions);
        instance.InstalledVerText.SetActive(showLaunchOptions);
    }
}

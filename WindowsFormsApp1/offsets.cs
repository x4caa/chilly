﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace WindowsFormsApp1
{
    public class Offsets
    {
        public static string
            //localplayer
            iLocalPlayer = "Minecraft.Windows.exe+049262A8,0,20,C8,0",
            //feet
            feetx = "Minecraft.Windows.exe+04926308,20,0,18,B8,3F0",
            feety = "Minecraft.Windows.exe+04926308,20,0,20,C8,3F4",
            feetz = "Minecraft.Windows.exe+04926308,20,0,18,B8,3F8",
            //head
            headx = "Minecraft.Windows.exe+049262F8,0,20,C8,3FC",
            heady = "Minecraft.Windows.exe+049262F8,0,18,B8,400",
            headz = "Minecraft.Windows.exe+049262F8,0,20,A0,B8,404",
            //reach
            reach = "Minecraft.Windows.exe+3F10808",
            //velocity
            velocityx = "Minecraft.Windows.exe+049262A8,0,20,C8,428",
            velocityy = "Minecraft.Windows.exe+049262F8,0,18,B8,42C",
            velocityz = "Minecraft.Windows.exe+049262F8,0,18,B8,430",
            //antikb
            antikbx = "Minecraft.Windows.exe+0x1A7F332",
            antikby = "Minecraft.Windows.exe+0x1A7F33B",
            antikbz = "Minecraft.Windows.exe+0x1A7F344",
            //hitbox
            hitboxwidth = "Minecraft.Windows.exe+19E69FF,F3,0F,10,83,08,04,00,00,48,83,C4,20,5B,C3,CC,CC,CC,40",
            //nameshit
            name = "Minecraft.Windows.exe+04926308,0,8,18,88,320",
            namelength = "Minecraft.Windows.exe+04926308,18,18,B8,8E8",
            //step
            step = "Minecraft.Windows.exe+049262F8,0,18,90,B8,21C",
            //fov
            fov = "Minecraft.Windows.exe+0487B460,18,180,18"
            ;
    }
}
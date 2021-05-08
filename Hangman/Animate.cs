﻿
namespace Hangman
{
    public class Animate
    {
        public static string[] limbs =
        {
            #region frames
            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"          ║    \n" +
            @"          ║    \n" +
            @"          ║    \n" +
            @"     ███  ║    \n" +
            @"    ══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      O   ║    \n" +
            @"          ║    \n" +
            @"          ║    \n" +
            @"     ███  ║    \n" +
            @"    ══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      O   ║    \n" +
            @"      |   ║    \n" +
            @"          ║    \n" +
            @"     ███  ║    \n" +
            @"    ══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      O   ║    \n" +
            @"      |\  ║    \n" +
            @"          ║    \n" +
            @"     ███  ║    \n" +
            @"    ══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      O   ║    \n" +
            @"     /|\  ║    \n" +
            @"          ║    \n" +
            @"     ███  ║    \n" +
            @"    ══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      O   ║    \n" +
            @"     /|\  ║    \n" +
            @"       \  ║    \n" +
            @"     ███  ║    \n" +
            @"    ══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      O   ║    \n" +
            @"     /|\  ║    \n" +
            @"     / \  ║    \n" +
            @"     ███  ║    \n" +
            @"    ══════╩═══",
            #endregion
        };

        public static string[] death =
        {
            #region Frames

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      O   ║    \n" +
            @"     /|\  ║    \n" +
            @"     / \  ║    \n" +
            @"     ███  ║    \n" +
            @"    ══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      O   ║    \n" +
            @"     /|\  ║    \n" +
            @"     / \  ║    \n" +
            @"          ║    \n" +
            @"    ══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      o>  ║    \n" +
            @"     /|   ║    \n" +
            @"      >\  ║    \n" +
            @"          ║    \n" +
            @"    ══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      O   ║    \n" +
            @"     /|\  ║    \n" +
            @"     / \  ║    \n" +
            @"          ║    \n" +
            @"    ══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"     <o   ║    \n" +
            @"      |\  ║    \n" +
            @"     /<   ║    \n" +
            @"          ║    \n" +
            @"    ══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      O   ║    \n" +
            @"     /|\  ║    \n" +
            @"     / \  ║    \n" +
            @"          ║    \n" +
            @"    ══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      o>  ║    \n" +
            @"     /|   ║    \n" +
            @"      >\  ║    \n" +
            @"          ║    \n" +
            @"    ══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      o>  ║    \n" +
            @"     /|   ║    \n" +
            @"      >\  ║    \n" +
            @"          ║    \n" +
            @"    ══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      O   ║    \n" +
            @"     /|\  ║    \n" +
            @"     / \  ║    \n" +
            @"          ║    \n" +
            @"    ══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"     <o   ║    \n" +
            @"      |\  ║    \n" +
            @"     /<   ║    \n" +
            @"          ║    \n" +
            @"    ══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"     <o   ║    \n" +
            @"      |\  ║    \n" +
            @"     /<   ║    \n" +
            @"          ║    \n" +
            @"    ══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"     <o   ║    \n" +
            @"      |\  ║    \n" +
            @"     /<   ║    \n" +
            @"          ║    \n" +
            @"    ══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      O   ║    \n" +
            @"     /|\  ║    \n" +
            @"     / \  ║    \n" +
            @"          ║    \n" +
            @"    ══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      o   ║    \n" +
            @"      |   ║    \n" +
            @"      |   ║    \n" +
            @"          ║    \n" +
            @"    ══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      o   ║    \n" +
            @"      |   ║    \n" +
            @"      |   ║    \n" +
            @"          ║    \n" +
            @"    ══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      o   ║    \n" +
            @"      |   ║    \n" +
            @"      |   ║    \n" +
            @"          ║    \n" +
            @"    ══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      o   ║    \n" +
            @"      |   ║    \n" +
            @"      |   ║    \n" +
            @"          ║    \n" +
            @"    ══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      o   ║    \n" +
            @"      |   ║    \n" +
            @"      |   ║    \n" +
            @"          ║    \n" +
            @"    ══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      o   ║    \n" +
            @"      |   ║    \n" +
            @"      |   ║    \n" +
            @"          ║    \n" +
            @"    ══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      O   ║    \n" +
            @"          ║    \n" +
            @"      |   ║    \n" +
            @"      |   ║    \n" +
            @"    ══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      O   ║    \n" +
            @"          ║    \n" +
            @"      /   ║    \n" +
            @"      \   ║    \n" +
            @"    ══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      O   ║    \n" +
            @"      '   ║    \n" +
            @"          ║    \n" +
            @"    |__   ║    \n" +
            @"    ══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      O   ║    \n" +
            @"      .   ║    \n" +
            @"          ║    \n" +
            @"    \__   ║    \n" +
            @"    ══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      O   ║    \n" +
            @"          ║    \n" +
            @"      '   ║    \n" +
            @"   ____   ║    \n" +
            @"    ══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      O   ║    \n" +
            @"      '   ║    \n" +
            @"      .   ║    \n" +
            @"    __    ║    \n" +
            @"   /══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      O   ║    \n" +
            @"      .   ║    \n" +
            @"          ║    \n" +
            @"    _ '   ║    \n" +
            @"  _/══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      O   ║    \n" +
            @"          ║    \n" +
            @"      '   ║    \n" +
            @"      _   ║    \n" +
            @" __/══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      O   ║    \n" +
            @"      '   ║    \n" +
            @"      .   ║    \n" +
            @"          ║    \n" +
            @" __/══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      O   ║    \n" +
            @"      .   ║    \n" +
            @"          ║    \n" +
            @"      '   ║    \n" +
            @" __/══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      O   ║    \n" +
            @"          ║    \n" +
            @"      '   ║    \n" +
            @"      _   ║    \n" +
            @" __/══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      O   ║    \n" +
            @"      '   ║    \n" +
            @"      .   ║    \n" +
            @"          ║    \n" +
            @" __/══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      O   ║    \n" +
            @"      .   ║    \n" +
            @"          ║    \n" +
            @"      '   ║    \n" +
            @" __/══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      O   ║    \n" +
            @"          ║    \n" +
            @"      '   ║    \n" +
            @"      _   ║    \n" +
            @" __/══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      O   ║    \n" +
            @"          ║    \n" +
            @"      .   ║    \n" +
            @"          ║    \n" +
            @" __/══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      O   ║    \n" +
            @"          ║    \n" +
            @"          ║    \n" +
            @"      '   ║    \n" +
            @" __/══════╩═══",

            @"      ╔═══╗    \n" +
            @"      |   ║    \n" +
            @"      O   ║    \n" +
            @"          ║    \n" +
            @"          ║    \n" +
            @"      _   ║    \n" +
            @" __/══════╩═══",
            #endregion
        };
    }
}
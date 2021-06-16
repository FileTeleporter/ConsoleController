/*
 * Copyright (C) 2021  Jolan Aklin And Yohan Zbinden

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <https://www.gnu.org/licenses/>.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileTeleporterNetController.Tools;

namespace FileTeleporterNetController
{
    class ShowConsole : Show
    {
        public override void ShowInfos(string title, string info)
        {
            EZConsole.WriteLine("infos", info);
        }

        public override void ShowErrors(string title, string error)
        {
            EZConsole.WriteLine("errors", error);
        }

        public override void ShowTransfers(string title, HandleNetController.Transfer[] transfers)
        {
            string text = "Current transfers : " + Environment.NewLine;
            for (int i = 0; i < transfers.Length; i++)
            {
                text += $" - FROM : {transfers[i].from} | TO : {transfers[i].to} | FILEPATH : {transfers[i].filepath} | FILESIZE : {transfers[i].fileSize}| STATUS : {transfers[i].status} | PROGRESS : {transfers[i].progress * 100}%";
                if (i < transfers.Length - 1)
                    text += Environment.NewLine;
            }
            EZConsole.WriteLine("transfers", text);
        }

        public override void ShowTransfers(string title, string transfer)
        {
            EZConsole.WriteLine("transfers", transfer);
        }

    }
}

﻿/*
 * Program : Ultrapowa Clash Server
 * Description : A C# Writted 'Clash of Clans' Server Emulator !
 *
 * Authors:  Jean-Baptiste Martin <Ultrapowa at Ultrapowa.com>,
 *           And the Official Ultrapowa Developement Team
 *
 * Copyright (c) 2016  UltraPowa
 * All Rights Reserved.
 */

using System.IO;
using UCS.Helpers;
using UCS.Logic;

namespace UCS.PacketProcessing.Commands
{
    internal class ClearObstacleCommand : Command
    {
        #region Public Constructors

        public ClearObstacleCommand(CoCSharpPacketReader br)
        {
            ObstacleId = br.ReadInt32WithEndian();
            Unknown1 = br.ReadUInt32WithEndian();
        }

        #endregion Public Constructors

        #region Public Methods

        public override void Execute(Level level)
        {
        }

        #endregion Public Methods

        #region Public Properties

        public int ObstacleId { get; set; }
        public uint Unknown1 { get; set; }

        #endregion Public Properties
    }
}
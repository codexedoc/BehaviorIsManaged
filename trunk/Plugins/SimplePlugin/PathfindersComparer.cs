﻿using System.Drawing;
using System.Linq;
using BiM.Behaviors;
using BiM.Behaviors.Game.World.Pathfinding;
using BiM.Core.Messages;
using BiM.Protocol.Messages;

namespace SimplePlugin
{
    public class PathfindersComparer
    {
        [MessageHandler(typeof (GameMapMovementRequestMessage))]
        public static void HandleGameMapMovementRequestMessage(Bot bot, GameMapMovementRequestMessage message)
        {
            bot.SendToClient(new DebugClearHighlightCellsMessage());

            var clientPath = Path.BuildFromClientCompressedPath(bot.Character.Map, message.keyMovements);


            var pathfinder = new Pathfinder(bot.Character.Map.CellInformationProvider);
            var botPath = pathfinder.FindPath(bot.Character.Position.Cell, clientPath.End, true);

            // if you see red cells it means the pathfinder is wrong and don't get the same path as the client
            bot.SendToClient(new DebugHighlightCellsMessage(Color.Red.ToArgb(), botPath.Cells.Select(entry => entry.Id).ToArray()));
            bot.SendToClient(new DebugHighlightCellsMessage(Color.Blue.ToArgb(), clientPath.Cells.Select(entry => entry.Id).ToArray()));
        }
    }
}
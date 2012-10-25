﻿using BiM.Core.Messages;
using BiM.Protocol.Messages;

namespace BiM.Behaviors.Handlers.Inventory
{
    public class InventoryHandler
    {
        [MessageHandler(typeof(InventoryContentMessage))]
        public static void HandleInventoryContentMessage(Bot bot, InventoryContentMessage message)
        {
            bot.Character.Inventory.Update(message);
        }

        [MessageHandler(typeof(InventoryWeightMessage))]
        public static void HandleInventoryWeightMessage(Bot bot, InventoryWeightMessage message)
        {
            bot.Character.Inventory.Update(message);
        }

        [MessageHandler(typeof(ObjectAddedMessage))]
        public static void HandleObjectAddedMessage(Bot bot, ObjectAddedMessage message)
        {
            bot.Character.Inventory.Update(message);
        }

        [MessageHandler(typeof(ObjectDeletedMessage))]
        public static void HandleObjectDeletedMessage(Bot bot, ObjectDeletedMessage message)
        {
            bot.Character.Inventory.Update(message);
        }

        [MessageHandler(typeof(ObjectModifiedMessage))]
        public static void HandleObjectModifiedMessage(Bot bot, ObjectModifiedMessage message)
        {
            bot.Character.Inventory.Update(message);
        }

        [MessageHandler(typeof(ObjectMovementMessage))]
        public static void HandleObjectMovementMessage(Bot bot, ObjectMovementMessage message)
        {
            bot.Character.Inventory.Update(message);
        }

        [MessageHandler(typeof(ObjectQuantityMessage))]
        public static void HandleObjectQuantityMessage(Bot bot, ObjectQuantityMessage message)
        {
            bot.Character.Inventory.Update(message);
        }

        [MessageHandler(typeof(ObjectsAddedMessage))]
        public static void HandleObjectsAddedMessage(Bot bot, ObjectsAddedMessage message)
        {
            bot.Character.Inventory.Update(message);
        }

        [MessageHandler(typeof(ObjectsDeletedMessage))]
        public static void HandleObjectsDeletedMessage(Bot bot, ObjectsDeletedMessage message)
        {
            bot.Character.Inventory.Update(message);
        }

        [MessageHandler(typeof(ObjectsQuantityMessage))]
        public static void HandleObjectsQuantityMessage(Bot bot, ObjectsQuantityMessage message)
        {
            bot.Character.Inventory.Update(message);
        }

        [MessageHandler(typeof(ObjectUseMessage))]
        public static void HandleObjectUseMessage(Bot bot, ObjectUseMessage message)
        {
            bot.Character.Inventory.Update(message);
        }

        [MessageHandler(typeof(ObjectUseMultipleMessage))]
        public static void HandleObjectUseMultipleMessage(Bot bot, ObjectUseMultipleMessage message)
        {
            bot.Character.Inventory.Update(message);
        }

        [MessageHandler(typeof(ObjectUseOnCellMessage))]
        public static void HandleObjectUseOnCellMessage(Bot bot, ObjectUseOnCellMessage message)
        {
            bot.Character.Inventory.Update(message);
        }

        [MessageHandler(typeof(ObjectUseOnCharacterMessage))]
        public static void HandleObjectUseOnCharacterMessage(Bot bot, ObjectUseOnCharacterMessage message)
        {
            bot.Character.Inventory.Update(message);
        }
    }
}
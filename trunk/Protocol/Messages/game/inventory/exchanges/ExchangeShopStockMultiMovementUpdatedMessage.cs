// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeShopStockMultiMovementUpdatedMessage.xml' the '27/06/2012 15:55:10'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class ExchangeShopStockMultiMovementUpdatedMessage : NetworkMessage
	{
		public const uint Id = 6038;
		public override uint MessageId
		{
			get
			{
				return 6038;
			}
		}
		
		public IEnumerable<Types.ObjectItemToSell> objectInfoList;
		
		public ExchangeShopStockMultiMovementUpdatedMessage()
		{
		}
		
		public ExchangeShopStockMultiMovementUpdatedMessage(IEnumerable<Types.ObjectItemToSell> objectInfoList)
		{
			this.objectInfoList = objectInfoList;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUShort((ushort)objectInfoList.Count());
			foreach (var entry in objectInfoList)
			{
				entry.Serialize(writer);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			int limit = reader.ReadUShort();
			objectInfoList = new Types.ObjectItemToSell[limit];
			for (int i = 0; i < limit; i++)
			{
				(objectInfoList as Types.ObjectItemToSell[])[i] = new Types.ObjectItemToSell();
				(objectInfoList as Types.ObjectItemToSell[])[i].Deserialize(reader);
			}
		}
	}
}

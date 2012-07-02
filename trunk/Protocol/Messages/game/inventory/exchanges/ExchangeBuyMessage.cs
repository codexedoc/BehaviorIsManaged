// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeBuyMessage.xml' the '27/06/2012 15:55:09'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class ExchangeBuyMessage : NetworkMessage
	{
		public const uint Id = 5774;
		public override uint MessageId
		{
			get
			{
				return 5774;
			}
		}
		
		public int objectToBuyId;
		public int quantity;
		
		public ExchangeBuyMessage()
		{
		}
		
		public ExchangeBuyMessage(int objectToBuyId, int quantity)
		{
			this.objectToBuyId = objectToBuyId;
			this.quantity = quantity;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(objectToBuyId);
			writer.WriteInt(quantity);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			objectToBuyId = reader.ReadInt();
			if ( objectToBuyId < 0 )
			{
				throw new Exception("Forbidden value on objectToBuyId = " + objectToBuyId + ", it doesn't respect the following condition : objectToBuyId < 0");
			}
			quantity = reader.ReadInt();
			if ( quantity < 0 )
			{
				throw new Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
			}
		}
	}
}

// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'TaxCollectorMovementRemoveMessage.xml' the '27/06/2012 15:55:08'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class TaxCollectorMovementRemoveMessage : NetworkMessage
	{
		public const uint Id = 5915;
		public override uint MessageId
		{
			get
			{
				return 5915;
			}
		}
		
		public int collectorId;
		
		public TaxCollectorMovementRemoveMessage()
		{
		}
		
		public TaxCollectorMovementRemoveMessage(int collectorId)
		{
			this.collectorId = collectorId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(collectorId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			collectorId = reader.ReadInt();
		}
	}
}

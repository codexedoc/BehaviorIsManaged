// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeOnHumanVendorRequestMessage.xml' the '27/06/2012 15:55:10'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class ExchangeOnHumanVendorRequestMessage : NetworkMessage
	{
		public const uint Id = 5772;
		public override uint MessageId
		{
			get
			{
				return 5772;
			}
		}
		
		public int humanVendorId;
		public int humanVendorCell;
		
		public ExchangeOnHumanVendorRequestMessage()
		{
		}
		
		public ExchangeOnHumanVendorRequestMessage(int humanVendorId, int humanVendorCell)
		{
			this.humanVendorId = humanVendorId;
			this.humanVendorCell = humanVendorCell;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(humanVendorId);
			writer.WriteInt(humanVendorCell);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			humanVendorId = reader.ReadInt();
			if ( humanVendorId < 0 )
			{
				throw new Exception("Forbidden value on humanVendorId = " + humanVendorId + ", it doesn't respect the following condition : humanVendorId < 0");
			}
			humanVendorCell = reader.ReadInt();
			if ( humanVendorCell < 0 )
			{
				throw new Exception("Forbidden value on humanVendorCell = " + humanVendorCell + ", it doesn't respect the following condition : humanVendorCell < 0");
			}
		}
	}
}

// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeStartOkCraftMessage.xml' the '27/06/2012 15:55:10'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class ExchangeStartOkCraftMessage : NetworkMessage
	{
		public const uint Id = 5813;
		public override uint MessageId
		{
			get
			{
				return 5813;
			}
		}
		
		
		public override void Serialize(IDataWriter writer)
		{
		}
		
		public override void Deserialize(IDataReader reader)
		{
		}
	}
}

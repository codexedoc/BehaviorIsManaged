// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'TeleportBuddiesAnswerMessage.xml' the '27/06/2012 15:55:08'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class TeleportBuddiesAnswerMessage : NetworkMessage
	{
		public const uint Id = 6294;
		public override uint MessageId
		{
			get
			{
				return 6294;
			}
		}
		
		public bool accept;
		
		public TeleportBuddiesAnswerMessage()
		{
		}
		
		public TeleportBuddiesAnswerMessage(bool accept)
		{
			this.accept = accept;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(accept);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			accept = reader.ReadBoolean();
		}
	}
}

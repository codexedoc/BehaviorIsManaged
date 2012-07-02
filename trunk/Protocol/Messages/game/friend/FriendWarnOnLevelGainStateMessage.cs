// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'FriendWarnOnLevelGainStateMessage.xml' the '27/06/2012 15:55:06'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class FriendWarnOnLevelGainStateMessage : NetworkMessage
	{
		public const uint Id = 6078;
		public override uint MessageId
		{
			get
			{
				return 6078;
			}
		}
		
		public bool enable;
		
		public FriendWarnOnLevelGainStateMessage()
		{
		}
		
		public FriendWarnOnLevelGainStateMessage(bool enable)
		{
			this.enable = enable;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(enable);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			enable = reader.ReadBoolean();
		}
	}
}

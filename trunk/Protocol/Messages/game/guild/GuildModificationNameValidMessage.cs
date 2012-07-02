// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GuildModificationNameValidMessage.xml' the '27/06/2012 15:55:07'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class GuildModificationNameValidMessage : NetworkMessage
	{
		public const uint Id = 6327;
		public override uint MessageId
		{
			get
			{
				return 6327;
			}
		}
		
		public string guildName;
		
		public GuildModificationNameValidMessage()
		{
		}
		
		public GuildModificationNameValidMessage(string guildName)
		{
			this.guildName = guildName;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(guildName);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			guildName = reader.ReadUTF();
		}
	}
}

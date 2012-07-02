// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GuildInvitedMessage.xml' the '27/06/2012 15:55:07'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class GuildInvitedMessage : NetworkMessage
	{
		public const uint Id = 5552;
		public override uint MessageId
		{
			get
			{
				return 5552;
			}
		}
		
		public int recruterId;
		public string recruterName;
		public Types.BasicGuildInformations guildInfo;
		
		public GuildInvitedMessage()
		{
		}
		
		public GuildInvitedMessage(int recruterId, string recruterName, Types.BasicGuildInformations guildInfo)
		{
			this.recruterId = recruterId;
			this.recruterName = recruterName;
			this.guildInfo = guildInfo;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(recruterId);
			writer.WriteUTF(recruterName);
			guildInfo.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			recruterId = reader.ReadInt();
			if ( recruterId < 0 )
			{
				throw new Exception("Forbidden value on recruterId = " + recruterId + ", it doesn't respect the following condition : recruterId < 0");
			}
			recruterName = reader.ReadUTF();
			guildInfo = new Types.BasicGuildInformations();
			guildInfo.Deserialize(reader);
		}
	}
}

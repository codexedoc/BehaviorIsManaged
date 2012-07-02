// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GuildInformationsMemberUpdateMessage.xml' the '27/06/2012 15:55:07'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class GuildInformationsMemberUpdateMessage : NetworkMessage
	{
		public const uint Id = 5597;
		public override uint MessageId
		{
			get
			{
				return 5597;
			}
		}
		
		public Types.GuildMember member;
		
		public GuildInformationsMemberUpdateMessage()
		{
		}
		
		public GuildInformationsMemberUpdateMessage(Types.GuildMember member)
		{
			this.member = member;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			member.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			member = new Types.GuildMember();
			member.Deserialize(reader);
		}
	}
}

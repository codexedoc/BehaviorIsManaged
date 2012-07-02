// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameRolePlayPlayerFightFriendlyAnswerMessage.xml' the '27/06/2012 15:55:02'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class GameRolePlayPlayerFightFriendlyAnswerMessage : NetworkMessage
	{
		public const uint Id = 5732;
		public override uint MessageId
		{
			get
			{
				return 5732;
			}
		}
		
		public int fightId;
		public bool accept;
		
		public GameRolePlayPlayerFightFriendlyAnswerMessage()
		{
		}
		
		public GameRolePlayPlayerFightFriendlyAnswerMessage(int fightId, bool accept)
		{
			this.fightId = fightId;
			this.accept = accept;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(fightId);
			writer.WriteBoolean(accept);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			fightId = reader.ReadInt();
			accept = reader.ReadBoolean();
		}
	}
}

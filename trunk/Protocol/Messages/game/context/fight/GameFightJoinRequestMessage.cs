// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameFightJoinRequestMessage.xml' the '27/06/2012 15:55:00'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class GameFightJoinRequestMessage : NetworkMessage
	{
		public const uint Id = 701;
		public override uint MessageId
		{
			get
			{
				return 701;
			}
		}
		
		public int fighterId;
		public int fightId;
		
		public GameFightJoinRequestMessage()
		{
		}
		
		public GameFightJoinRequestMessage(int fighterId, int fightId)
		{
			this.fighterId = fighterId;
			this.fightId = fightId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(fighterId);
			writer.WriteInt(fightId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			fighterId = reader.ReadInt();
			fightId = reader.ReadInt();
		}
	}
}

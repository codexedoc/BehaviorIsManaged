// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'DungeonPartyFinderAvailableDungeonsRequestMessage.xml' the '27/06/2012 15:55:04'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class DungeonPartyFinderAvailableDungeonsRequestMessage : NetworkMessage
	{
		public const uint Id = 6240;
		public override uint MessageId
		{
			get
			{
				return 6240;
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

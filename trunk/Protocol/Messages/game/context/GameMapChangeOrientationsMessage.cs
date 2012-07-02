// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameMapChangeOrientationsMessage.xml' the '27/06/2012 15:55:00'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class GameMapChangeOrientationsMessage : NetworkMessage
	{
		public const uint Id = 6155;
		public override uint MessageId
		{
			get
			{
				return 6155;
			}
		}
		
		public IEnumerable<Types.ActorOrientation> orientations;
		
		public GameMapChangeOrientationsMessage()
		{
		}
		
		public GameMapChangeOrientationsMessage(IEnumerable<Types.ActorOrientation> orientations)
		{
			this.orientations = orientations;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUShort((ushort)orientations.Count());
			foreach (var entry in orientations)
			{
				entry.Serialize(writer);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			int limit = reader.ReadUShort();
			orientations = new Types.ActorOrientation[limit];
			for (int i = 0; i < limit; i++)
			{
				(orientations as Types.ActorOrientation[])[i] = new Types.ActorOrientation();
				(orientations as Types.ActorOrientation[])[i].Deserialize(reader);
			}
		}
	}
}

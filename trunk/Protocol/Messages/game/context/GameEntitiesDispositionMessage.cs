// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameEntitiesDispositionMessage.xml' the '27/06/2012 15:55:00'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class GameEntitiesDispositionMessage : NetworkMessage
	{
		public const uint Id = 5696;
		public override uint MessageId
		{
			get
			{
				return 5696;
			}
		}
		
		public IEnumerable<Types.IdentifiedEntityDispositionInformations> dispositions;
		
		public GameEntitiesDispositionMessage()
		{
		}
		
		public GameEntitiesDispositionMessage(IEnumerable<Types.IdentifiedEntityDispositionInformations> dispositions)
		{
			this.dispositions = dispositions;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUShort((ushort)dispositions.Count());
			foreach (var entry in dispositions)
			{
				entry.Serialize(writer);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			int limit = reader.ReadUShort();
			dispositions = new Types.IdentifiedEntityDispositionInformations[limit];
			for (int i = 0; i < limit; i++)
			{
				(dispositions as Types.IdentifiedEntityDispositionInformations[])[i] = new Types.IdentifiedEntityDispositionInformations();
				(dispositions as Types.IdentifiedEntityDispositionInformations[])[i].Deserialize(reader);
			}
		}
	}
}

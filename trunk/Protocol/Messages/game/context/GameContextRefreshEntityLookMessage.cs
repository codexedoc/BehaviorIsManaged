// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameContextRefreshEntityLookMessage.xml' the '27/06/2012 15:55:00'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class GameContextRefreshEntityLookMessage : NetworkMessage
	{
		public const uint Id = 5637;
		public override uint MessageId
		{
			get
			{
				return 5637;
			}
		}
		
		public int id;
		public Types.EntityLook look;
		
		public GameContextRefreshEntityLookMessage()
		{
		}
		
		public GameContextRefreshEntityLookMessage(int id, Types.EntityLook look)
		{
			this.id = id;
			this.look = look;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(id);
			look.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			id = reader.ReadInt();
			look = new Types.EntityLook();
			look.Deserialize(reader);
		}
	}
}

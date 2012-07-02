// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'BasicTimeMessage.xml' the '27/06/2012 15:54:58'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class BasicTimeMessage : NetworkMessage
	{
		public const uint Id = 175;
		public override uint MessageId
		{
			get
			{
				return 175;
			}
		}
		
		public int timestamp;
		public short timezoneOffset;
		
		public BasicTimeMessage()
		{
		}
		
		public BasicTimeMessage(int timestamp, short timezoneOffset)
		{
			this.timestamp = timestamp;
			this.timezoneOffset = timezoneOffset;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(timestamp);
			writer.WriteShort(timezoneOffset);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			timestamp = reader.ReadInt();
			if ( timestamp < 0 )
			{
				throw new Exception("Forbidden value on timestamp = " + timestamp + ", it doesn't respect the following condition : timestamp < 0");
			}
			timezoneOffset = reader.ReadShort();
		}
	}
}

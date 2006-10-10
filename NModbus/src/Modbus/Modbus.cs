using System;
using System.Collections.Generic;
using System.Text;

namespace Modbus
{	
	/// <summary>
	///  Defines constants related to the Modbus protocol.
	/// </summary>
	public static class Modbus
	{			
		// public function codes
		public const byte ReadCoils = 1;
		public const byte ReadInputs = 2;
		public const byte ReadHoldingRegisters = 3;
		public const byte ReadInputRegisters = 4;
		public const byte WriteSingleCoil = 5;
		public const byte WriteSingleRegister = 6;
		//public const byte ReadExceptionStatus = 7;
		//public const byte Diagnostics = 8;
		public const byte WriteMultipleCoils = 15;
		public const byte WriteMultipleRegisters = 16;

		// modbus slave exception offset that is added to the function code, to flag an exception
		public const byte ExceptionOffset = 128;

		// default setting for number of retries for IO operations
		public const int DefaultRetries = 3;

		// default setting for IO timeouts in milliseconds
		public const int DefaultTimeout = 1000;

		// smallest supported message frame size (sans checksum)
		public const int MinimumFrameSize = 2;

		public const ushort CoilOn = 0xFF00;
		public const ushort CoilOff = 0x0000;

		// Tcp slaves should be addressed by IP
		public const byte DefaultTcpSlaveUnitID = 0;
	}
}
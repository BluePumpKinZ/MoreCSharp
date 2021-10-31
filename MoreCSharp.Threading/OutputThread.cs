using System;
using System.Globalization;
using System.Runtime.Versioning;
using System.Security.Principal;
using System.Threading;

namespace MoreCSharp.Threading {

	public class ReturnThread<T> {

		private readonly Thread _thread;
		public T Result { get; private set; }
		public bool HasResult { get; private set; }

		public ReturnThread (Func<T> function) {
			_thread = new Thread (GetThreadStart (function));
		}

		public ReturnThread (Func<T> function, int maxStackSize) {
			_thread = new Thread (GetThreadStart (function), maxStackSize);
		}

		private ThreadStart GetThreadStart (Func<T> function) {
			return () => {
				Result = function.Invoke ();
				HasResult = true;
			};
		}

		public CultureInfo CurrentCulture {
			set { _thread.CurrentCulture = value; }
			get { return _thread.CurrentCulture; }
		}

		public ApartmentState ApartmentState {
			get { return GetApartmentState (); }
			[SupportedOSPlatform ("windows")] set { SetApartmentState (value); }
		}

		public static IPrincipal CurrentPrincipal => Thread.CurrentPrincipal;

		public static Thread CurrentThread => Thread.CurrentThread;

		public CultureInfo CurrentUICulture {
			set { _thread.CurrentUICulture = value; }
			get { return _thread.CurrentUICulture; }
		}

		public ExecutionContext ExecutionContext => _thread.ExecutionContext;

		public bool IsAlive => _thread.IsAlive;

		public bool IsBackGround {
			set { _thread.IsBackground = value; }
			get { return _thread.IsBackground; }
		}

		public bool IsThreadPoolThread => _thread.IsThreadPoolThread;

		public int ManagedThreadId => _thread.ManagedThreadId;

		public string Name {
			set { _thread.Name = value; }
			get { return _thread.Name; }
		}

		public ThreadPriority Priority {
			set { _thread.Priority = value; }
			get { return _thread.Priority; }
		}

		public ThreadState ThreadState => _thread.ThreadState;

		public static LocalDataStoreSlot AllocateDataSlot () => Thread.AllocateDataSlot ();

		public static LocalDataStoreSlot AllocateNamedDataSlot (string name) => Thread.AllocateNamedDataSlot (name);

		public static void BeginCriticalRegion () => Thread.BeginCriticalRegion ();

		public static void BeginThreadAffinity () => Thread.BeginThreadAffinity ();

		public void DisableComObjectEagerCleanup () => _thread.DisableComObjectEagerCleanup ();

		public static void EndCriticalRegion () => Thread.EndCriticalRegion ();

		public static void EndThreadAffinity () => Thread.EndThreadAffinity ();

		public static void FreeNamedDataSlot (string name) => Thread.FreeNamedDataSlot (name);

		public ApartmentState GetApartmentState () => _thread.GetApartmentState ();

		public int GetCurrentProcessorId () => Thread.GetCurrentProcessorId ();

		public static object GetData (LocalDataStoreSlot slot) => Thread.GetData (slot);

		public static AppDomain GetDomain () => Thread.GetDomain ();

		public static int GetDomainId () => Thread.GetDomainID ();

		public static LocalDataStoreSlot GetNamedDataSlot (string name) => Thread.GetNamedDataSlot (name);

		public void Interrupt () => _thread.Interrupt ();

		public void Join () => _thread.Join ();

		public void Join (int millisecondsTimeout) => _thread.Join (millisecondsTimeout);

		public void Join (TimeSpan timeout) => _thread.Join (timeout);

		public static void MemoryBarrier () => Thread.MemoryBarrier ();

		[SupportedOSPlatform ("windows")]
		public void SetApartmentState (ApartmentState apartmentState) => _thread.SetApartmentState (apartmentState);

		public static void SetData (LocalDataStoreSlot slot, object data) => Thread.SetData (slot, data);

		public void Start () => _thread.Start ();

		public bool TrySetApartmentState (ApartmentState state) => _thread.TrySetApartmentState (state);


		public static byte VolatileRead (ref byte address) => Thread.VolatileRead (ref address);

		public static sbyte VolatileRead (ref sbyte address) => Thread.VolatileRead (ref address);

		public static short VolatileRead (ref short address) => Thread.VolatileRead (ref address);

		public static ushort VolatileRead (ref ushort address) => Thread.VolatileRead (ref address);

		public static int VolatileRead (ref int address) => Thread.VolatileRead (ref address);

		public static uint VolatileRead (ref uint address) => Thread.VolatileRead (ref address);

		public static long VolatileRead (ref long address) => Thread.VolatileRead (ref address);

		public static ulong VolatileRead (ref ulong address) => Thread.VolatileRead (ref address);

		public static float VolatileRead (ref float address) => Thread.VolatileRead (ref address);

		public static double VolatileRead (ref double address) => Thread.VolatileRead (ref address);

		public static object VolatileRead (ref object address) => Thread.VolatileRead (ref address);

		public static IntPtr VolatileRead (ref IntPtr address) => Thread.VolatileRead (ref address);

		public static UIntPtr VolatileRead (ref UIntPtr address) => Thread.VolatileRead (ref address);


		public static void VolatileWrite (ref byte address, byte value) => Thread.VolatileWrite (ref address, value);

		public static void VolatileWrite (ref sbyte address, sbyte value) => Thread.VolatileWrite (ref address, value);

		public static void VolatileWrite (ref short address, short value) => Thread.VolatileWrite (ref address, value);

		public static void VolatileWrite (ref ushort address, ushort value) => Thread.VolatileWrite (ref address, value);

		public static void VolatileWrite (ref int address, int value) => Thread.VolatileWrite (ref address, value);

		public static void VolatileWrite (ref uint address, uint value) => Thread.VolatileWrite (ref address, value);

		public static void VolatileWrite (ref long address, long value) => Thread.VolatileWrite (ref address, value);

		public static void VolatileWrite (ref ulong address, ulong value) => Thread.VolatileWrite (ref address, value);

		public static void VolatileWrite (ref float address, float value) => Thread.VolatileWrite (ref address, value);

		public static void VolatileWrite (ref double address, double value) => Thread.VolatileWrite (ref address, value);

		public static void VolatileWrite (ref object address, object value) => Thread.VolatileWrite (ref address, value);

		public static void VolatileWrite (ref IntPtr address, IntPtr value) => Thread.VolatileWrite (ref address, value);

		public static void VolatileWrite (ref UIntPtr address, UIntPtr value) => Thread.VolatileWrite (ref address, value);

	}

}

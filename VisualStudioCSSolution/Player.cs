//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Player : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Player(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Player obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Player() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bcPINVOKE.delete_Player(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public Player(Team team, Planet planet) : this(bcPINVOKE.new_Player((int)team, (int)planet), true) {
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
  }

  public string debug() {
    string ret = bcPINVOKE.Player_debug(swigCPtr);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Player clone() {
    global::System.IntPtr cPtr = bcPINVOKE.Player_clone(swigCPtr);
    Player ret = (cPtr == global::System.IntPtr.Zero) ? null : new Player(cPtr, false);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public byte eq(Player other) {
    byte ret = bcPINVOKE.Player_eq(swigCPtr, Player.getCPtr(other));
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string to_json() {
    string ret = bcPINVOKE.Player_to_json(swigCPtr);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Team team {
    set {
      bcPINVOKE.Player_team_set(swigCPtr, (int)value);
      if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      Team ret = (Team)bcPINVOKE.Player_team_get(swigCPtr);
      if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public Planet planet {
    set {
      bcPINVOKE.Player_planet_set(swigCPtr, (int)value);
      if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      Planet ret = (Planet)bcPINVOKE.Player_planet_get(swigCPtr);
      if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}
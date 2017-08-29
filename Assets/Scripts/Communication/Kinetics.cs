// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: kinetics.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Rochester.Physics.Communication {

  /// <summary>Holder for reflection information generated from kinetics.proto</summary>
  public static partial class KineticsReflection {

    #region Descriptor
    /// <summary>File descriptor for kinetics.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KineticsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5raW5ldGljcy5wcm90bxIIcmVhY3RvcnMiTwoPUmVhY3RvcktpbmV0aWNz",
            "EhMKC3RlbXBlcmF0dXJlGAEgASgCEhAKCHByZXNzdXJlGAIgASgCEhUKDW1v",
            "bGVfZnJhY3Rpb24YAyADKAIiSwoOU3lzdGVtS2luZXRpY3MSDAoEdGltZRgB",
            "IAEoAxIrCghraW5ldGljcxgCIAMoCzIZLnJlYWN0b3JzLlJlYWN0b3JLaW5l",
            "dGljc0IiqgIfUm9jaGVzdGVyLlBoeXNpY3MuQ29tbXVuaWNhdGlvbmIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Rochester.Physics.Communication.ReactorKinetics), global::Rochester.Physics.Communication.ReactorKinetics.Parser, new[]{ "Temperature", "Pressure", "MoleFraction" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Rochester.Physics.Communication.SystemKinetics), global::Rochester.Physics.Communication.SystemKinetics.Parser, new[]{ "Time", "Kinetics" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReactorKinetics : pb::IMessage<ReactorKinetics> {
    private static readonly pb::MessageParser<ReactorKinetics> _parser = new pb::MessageParser<ReactorKinetics>(() => new ReactorKinetics());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReactorKinetics> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Rochester.Physics.Communication.KineticsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReactorKinetics() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReactorKinetics(ReactorKinetics other) : this() {
      temperature_ = other.temperature_;
      pressure_ = other.pressure_;
      moleFraction_ = other.moleFraction_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReactorKinetics Clone() {
      return new ReactorKinetics(this);
    }

    /// <summary>Field number for the "temperature" field.</summary>
    public const int TemperatureFieldNumber = 1;
    private float temperature_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Temperature {
      get { return temperature_; }
      set {
        temperature_ = value;
      }
    }

    /// <summary>Field number for the "pressure" field.</summary>
    public const int PressureFieldNumber = 2;
    private float pressure_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Pressure {
      get { return pressure_; }
      set {
        pressure_ = value;
      }
    }

    /// <summary>Field number for the "mole_fraction" field.</summary>
    public const int MoleFractionFieldNumber = 3;
    private static readonly pb::FieldCodec<float> _repeated_moleFraction_codec
        = pb::FieldCodec.ForFloat(26);
    private readonly pbc::RepeatedField<float> moleFraction_ = new pbc::RepeatedField<float>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<float> MoleFraction {
      get { return moleFraction_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReactorKinetics);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReactorKinetics other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Temperature != other.Temperature) return false;
      if (Pressure != other.Pressure) return false;
      if(!moleFraction_.Equals(other.moleFraction_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Temperature != 0F) hash ^= Temperature.GetHashCode();
      if (Pressure != 0F) hash ^= Pressure.GetHashCode();
      hash ^= moleFraction_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Temperature != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(Temperature);
      }
      if (Pressure != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(Pressure);
      }
      moleFraction_.WriteTo(output, _repeated_moleFraction_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Temperature != 0F) {
        size += 1 + 4;
      }
      if (Pressure != 0F) {
        size += 1 + 4;
      }
      size += moleFraction_.CalculateSize(_repeated_moleFraction_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReactorKinetics other) {
      if (other == null) {
        return;
      }
      if (other.Temperature != 0F) {
        Temperature = other.Temperature;
      }
      if (other.Pressure != 0F) {
        Pressure = other.Pressure;
      }
      moleFraction_.Add(other.moleFraction_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 13: {
            Temperature = input.ReadFloat();
            break;
          }
          case 21: {
            Pressure = input.ReadFloat();
            break;
          }
          case 26:
          case 29: {
            moleFraction_.AddEntriesFrom(input, _repeated_moleFraction_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class SystemKinetics : pb::IMessage<SystemKinetics> {
    private static readonly pb::MessageParser<SystemKinetics> _parser = new pb::MessageParser<SystemKinetics>(() => new SystemKinetics());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SystemKinetics> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Rochester.Physics.Communication.KineticsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SystemKinetics() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SystemKinetics(SystemKinetics other) : this() {
      time_ = other.time_;
      kinetics_ = other.kinetics_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SystemKinetics Clone() {
      return new SystemKinetics(this);
    }

    /// <summary>Field number for the "time" field.</summary>
    public const int TimeFieldNumber = 1;
    private long time_;
    /// <summary>
    ///timestamp
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    /// <summary>Field number for the "kinetics" field.</summary>
    public const int KineticsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Rochester.Physics.Communication.ReactorKinetics> _repeated_kinetics_codec
        = pb::FieldCodec.ForMessage(18, global::Rochester.Physics.Communication.ReactorKinetics.Parser);
    private readonly pbc::RepeatedField<global::Rochester.Physics.Communication.ReactorKinetics> kinetics_ = new pbc::RepeatedField<global::Rochester.Physics.Communication.ReactorKinetics>();
    /// <summary>
    ///repeats for all components(reactors and pipes) in the system
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Rochester.Physics.Communication.ReactorKinetics> Kinetics {
      get { return kinetics_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SystemKinetics);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SystemKinetics other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Time != other.Time) return false;
      if(!kinetics_.Equals(other.kinetics_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Time != 0L) hash ^= Time.GetHashCode();
      hash ^= kinetics_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Time != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Time);
      }
      kinetics_.WriteTo(output, _repeated_kinetics_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Time != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Time);
      }
      size += kinetics_.CalculateSize(_repeated_kinetics_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SystemKinetics other) {
      if (other == null) {
        return;
      }
      if (other.Time != 0L) {
        Time = other.Time;
      }
      kinetics_.Add(other.kinetics_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Time = input.ReadInt64();
            break;
          }
          case 18: {
            kinetics_.AddEntriesFrom(input, _repeated_kinetics_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

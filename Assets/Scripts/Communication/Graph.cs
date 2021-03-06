// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: graph.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Rochester.Physics.Communication {

  /// <summary>Holder for reflection information generated from graph.proto</summary>
  public static partial class GraphReflection {

    #region Descriptor
    /// <summary>File descriptor for graph.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GraphReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgtncmFwaC5wcm90bxIGZ3JhcGhzIlMKBE5vZGUSCgoCaWQYASABKAUSDQoF",
            "bGFiZWwYAiABKAkSDgoGZGVsZXRlGAMgASgIEhAKCHBvc2l0aW9uGAQgAygC",
            "Eg4KBndlaWdodBgFIAMoAiJQCgRFZGdlEgsKA2lkQRgBIAEoBRIOCgZsYWJl",
            "bEEYAiABKAkSCwoDaWRCGAMgASgFEg4KBmxhYmVsQhgEIAEoCRIOCgZ3ZWln",
            "aHQYBSADKAIi3wEKBUdyYXBoEgwKBHRpbWUYASABKAMSJwoFbm9kZXMYAiAD",
            "KAsyGC5ncmFwaHMuR3JhcGguTm9kZXNFbnRyeRInCgVlZGdlcxgDIAMoCzIY",
            "LmdyYXBocy5HcmFwaC5FZGdlc0VudHJ5GjoKCk5vZGVzRW50cnkSCwoDa2V5",
            "GAEgASgFEhsKBXZhbHVlGAIgASgLMgwuZ3JhcGhzLk5vZGU6AjgBGjoKCkVk",
            "Z2VzRW50cnkSCwoDa2V5GAEgASgFEhsKBXZhbHVlGAIgASgLMgwuZ3JhcGhz",
            "LkVkZ2U6AjgBQiKqAh9Sb2NoZXN0ZXIuUGh5c2ljcy5Db21tdW5pY2F0aW9u",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Rochester.Physics.Communication.Node), global::Rochester.Physics.Communication.Node.Parser, new[]{ "Id", "Label", "Delete", "Position", "Weight" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Rochester.Physics.Communication.Edge), global::Rochester.Physics.Communication.Edge.Parser, new[]{ "IdA", "LabelA", "IdB", "LabelB", "Weight" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Rochester.Physics.Communication.Graph), global::Rochester.Physics.Communication.Graph.Parser, new[]{ "Time", "Nodes", "Edges" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Node : pb::IMessage<Node> {
    private static readonly pb::MessageParser<Node> _parser = new pb::MessageParser<Node>(() => new Node());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Node> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Rochester.Physics.Communication.GraphReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Node() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Node(Node other) : this() {
      id_ = other.id_;
      label_ = other.label_;
      delete_ = other.delete_;
      position_ = other.position_.Clone();
      weight_ = other.weight_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Node Clone() {
      return new Node(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "label" field.</summary>
    public const int LabelFieldNumber = 2;
    private string label_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Label {
      get { return label_; }
      set {
        label_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "delete" field.</summary>
    public const int DeleteFieldNumber = 3;
    private bool delete_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Delete {
      get { return delete_; }
      set {
        delete_ = value;
      }
    }

    /// <summary>Field number for the "position" field.</summary>
    public const int PositionFieldNumber = 4;
    private static readonly pb::FieldCodec<float> _repeated_position_codec
        = pb::FieldCodec.ForFloat(34);
    private readonly pbc::RepeatedField<float> position_ = new pbc::RepeatedField<float>();
    /// <summary>
    ///for unity rendering
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<float> Position {
      get { return position_; }
    }

    /// <summary>Field number for the "weight" field.</summary>
    public const int WeightFieldNumber = 5;
    private static readonly pb::FieldCodec<float> _repeated_weight_codec
        = pb::FieldCodec.ForFloat(42);
    private readonly pbc::RepeatedField<float> weight_ = new pbc::RepeatedField<float>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<float> Weight {
      get { return weight_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Node);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Node other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Label != other.Label) return false;
      if (Delete != other.Delete) return false;
      if(!position_.Equals(other.position_)) return false;
      if(!weight_.Equals(other.weight_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Label.Length != 0) hash ^= Label.GetHashCode();
      if (Delete != false) hash ^= Delete.GetHashCode();
      hash ^= position_.GetHashCode();
      hash ^= weight_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (Label.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Label);
      }
      if (Delete != false) {
        output.WriteRawTag(24);
        output.WriteBool(Delete);
      }
      position_.WriteTo(output, _repeated_position_codec);
      weight_.WriteTo(output, _repeated_weight_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Label.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Label);
      }
      if (Delete != false) {
        size += 1 + 1;
      }
      size += position_.CalculateSize(_repeated_position_codec);
      size += weight_.CalculateSize(_repeated_weight_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Node other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Label.Length != 0) {
        Label = other.Label;
      }
      if (other.Delete != false) {
        Delete = other.Delete;
      }
      position_.Add(other.position_);
      weight_.Add(other.weight_);
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
            Id = input.ReadInt32();
            break;
          }
          case 18: {
            Label = input.ReadString();
            break;
          }
          case 24: {
            Delete = input.ReadBool();
            break;
          }
          case 34:
          case 37: {
            position_.AddEntriesFrom(input, _repeated_position_codec);
            break;
          }
          case 42:
          case 45: {
            weight_.AddEntriesFrom(input, _repeated_weight_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Edge : pb::IMessage<Edge> {
    private static readonly pb::MessageParser<Edge> _parser = new pb::MessageParser<Edge>(() => new Edge());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Edge> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Rochester.Physics.Communication.GraphReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Edge() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Edge(Edge other) : this() {
      idA_ = other.idA_;
      labelA_ = other.labelA_;
      idB_ = other.idB_;
      labelB_ = other.labelB_;
      weight_ = other.weight_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Edge Clone() {
      return new Edge(this);
    }

    /// <summary>Field number for the "idA" field.</summary>
    public const int IdAFieldNumber = 1;
    private int idA_;
    /// <summary>
    ///designate node pairs by their Node.id and Node.type values.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int IdA {
      get { return idA_; }
      set {
        idA_ = value;
      }
    }

    /// <summary>Field number for the "labelA" field.</summary>
    public const int LabelAFieldNumber = 2;
    private string labelA_ = "";
    /// <summary>
    ///need both for Unity dict, otherwise can't connect different node types
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LabelA {
      get { return labelA_; }
      set {
        labelA_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "idB" field.</summary>
    public const int IdBFieldNumber = 3;
    private int idB_;
    /// <summary>
    ///for digraphs, always point from A to B
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int IdB {
      get { return idB_; }
      set {
        idB_ = value;
      }
    }

    /// <summary>Field number for the "labelB" field.</summary>
    public const int LabelBFieldNumber = 4;
    private string labelB_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LabelB {
      get { return labelB_; }
      set {
        labelB_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "weight" field.</summary>
    public const int WeightFieldNumber = 5;
    private static readonly pb::FieldCodec<float> _repeated_weight_codec
        = pb::FieldCodec.ForFloat(42);
    private readonly pbc::RepeatedField<float> weight_ = new pbc::RepeatedField<float>();
    /// <summary>
    ///as many weights as you like
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<float> Weight {
      get { return weight_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Edge);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Edge other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IdA != other.IdA) return false;
      if (LabelA != other.LabelA) return false;
      if (IdB != other.IdB) return false;
      if (LabelB != other.LabelB) return false;
      if(!weight_.Equals(other.weight_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IdA != 0) hash ^= IdA.GetHashCode();
      if (LabelA.Length != 0) hash ^= LabelA.GetHashCode();
      if (IdB != 0) hash ^= IdB.GetHashCode();
      if (LabelB.Length != 0) hash ^= LabelB.GetHashCode();
      hash ^= weight_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (IdA != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(IdA);
      }
      if (LabelA.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(LabelA);
      }
      if (IdB != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(IdB);
      }
      if (LabelB.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(LabelB);
      }
      weight_.WriteTo(output, _repeated_weight_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IdA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(IdA);
      }
      if (LabelA.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LabelA);
      }
      if (IdB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(IdB);
      }
      if (LabelB.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LabelB);
      }
      size += weight_.CalculateSize(_repeated_weight_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Edge other) {
      if (other == null) {
        return;
      }
      if (other.IdA != 0) {
        IdA = other.IdA;
      }
      if (other.LabelA.Length != 0) {
        LabelA = other.LabelA;
      }
      if (other.IdB != 0) {
        IdB = other.IdB;
      }
      if (other.LabelB.Length != 0) {
        LabelB = other.LabelB;
      }
      weight_.Add(other.weight_);
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
            IdA = input.ReadInt32();
            break;
          }
          case 18: {
            LabelA = input.ReadString();
            break;
          }
          case 24: {
            IdB = input.ReadInt32();
            break;
          }
          case 34: {
            LabelB = input.ReadString();
            break;
          }
          case 42:
          case 45: {
            weight_.AddEntriesFrom(input, _repeated_weight_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Graph : pb::IMessage<Graph> {
    private static readonly pb::MessageParser<Graph> _parser = new pb::MessageParser<Graph>(() => new Graph());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Graph> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Rochester.Physics.Communication.GraphReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Graph() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Graph(Graph other) : this() {
      time_ = other.time_;
      nodes_ = other.nodes_.Clone();
      edges_ = other.edges_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Graph Clone() {
      return new Graph(this);
    }

    /// <summary>Field number for the "time" field.</summary>
    public const int TimeFieldNumber = 1;
    private long time_;
    /// <summary>
    ///timestamp for simulations
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    /// <summary>Field number for the "nodes" field.</summary>
    public const int NodesFieldNumber = 2;
    private static readonly pbc::MapField<int, global::Rochester.Physics.Communication.Node>.Codec _map_nodes_codec
        = new pbc::MapField<int, global::Rochester.Physics.Communication.Node>.Codec(pb::FieldCodec.ForInt32(8), pb::FieldCodec.ForMessage(18, global::Rochester.Physics.Communication.Node.Parser), 18);
    private readonly pbc::MapField<int, global::Rochester.Physics.Communication.Node> nodes_ = new pbc::MapField<int, global::Rochester.Physics.Communication.Node>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, global::Rochester.Physics.Communication.Node> Nodes {
      get { return nodes_; }
    }

    /// <summary>Field number for the "edges" field.</summary>
    public const int EdgesFieldNumber = 3;
    private static readonly pbc::MapField<int, global::Rochester.Physics.Communication.Edge>.Codec _map_edges_codec
        = new pbc::MapField<int, global::Rochester.Physics.Communication.Edge>.Codec(pb::FieldCodec.ForInt32(8), pb::FieldCodec.ForMessage(18, global::Rochester.Physics.Communication.Edge.Parser), 26);
    private readonly pbc::MapField<int, global::Rochester.Physics.Communication.Edge> edges_ = new pbc::MapField<int, global::Rochester.Physics.Communication.Edge>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, global::Rochester.Physics.Communication.Edge> Edges {
      get { return edges_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Graph);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Graph other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Time != other.Time) return false;
      if (!Nodes.Equals(other.Nodes)) return false;
      if (!Edges.Equals(other.Edges)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Time != 0L) hash ^= Time.GetHashCode();
      hash ^= Nodes.GetHashCode();
      hash ^= Edges.GetHashCode();
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
      nodes_.WriteTo(output, _map_nodes_codec);
      edges_.WriteTo(output, _map_edges_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Time != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Time);
      }
      size += nodes_.CalculateSize(_map_nodes_codec);
      size += edges_.CalculateSize(_map_edges_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Graph other) {
      if (other == null) {
        return;
      }
      if (other.Time != 0L) {
        Time = other.Time;
      }
      nodes_.Add(other.nodes_);
      edges_.Add(other.edges_);
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
            nodes_.AddEntriesFrom(input, _map_nodes_codec);
            break;
          }
          case 26: {
            edges_.AddEntriesFrom(input, _map_edges_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

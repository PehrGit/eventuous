namespace Eventuous.EventStore.Producers; 

[PublicAPI]
public class EventStoreProduceOptions {
    /// <summary>
    /// User credentials
    /// </summary>
    public UserCredentials? Credentials { get; init; }
        
    /// <summary>
    /// Expected stream state
    /// </summary>
    public StreamState ExpectedState { get; init; } = StreamState.Any;

    /// <summary>
    /// Maximum number of events appended to a single stream in one batch
    /// </summary>
    public int MaxAppendEventsCound { get; init; } = 500;

    /// <summary>
    /// Optional function to configure client operation options
    /// </summary>
    public Action<EventStoreClientOperationOptions>? ConfigureOperation { get; init; }

    public static EventStoreProduceOptions Default { get; } = new();
}
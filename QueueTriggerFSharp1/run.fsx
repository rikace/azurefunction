let Run(myQueueItem: string, log: TraceWriter) =
    log.Info(sprintf "F# Queue trigger function processed WOOT WOOOT : '%s'" myQueueItem)

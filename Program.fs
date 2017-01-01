// Learn more about F# at http://fsharp.org

open Suave;

[<EntryPoint>]
startWebServer defaultConfig (Successful.OK "Hello World from F#!")

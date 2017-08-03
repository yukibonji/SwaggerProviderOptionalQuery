#r "packages/SwaggerProvider/lib/net45/SwaggerProvider.Runtime.dll"

#r "packages/SwaggerProvider/lib/net45/SwaggerProvider.dll"

open SwaggerProvider

let [<Literal>] scheme = __SOURCE_DIRECTORY__ + "./swagger.json "

type Test = SwaggerProvider<scheme>

let t = Test()

let x = t.GetAccounts
# easy-signalR
brief signalR sample for article in [medium](https://cheoalfredo.medium.com/un-cuento-super-cortito-acerca-de-websockets-y-signalr-7497d2ab5977)

# Instrucciones 

* Ejecute el proyecto con "dotnet run"
* Ejecute Insomnia (rest client) y cree una solicitud de tipo WebSocket apuntando a http://localhost:port/ws donde el puerto es el que abre tu webapi
* Envie mensaje inicial al servidor para especificar que la comunicacion ser hará con JSON, este es el payload (ojo con el caracter final, es necesario)
  <pre>
  {"protocol":"json","version":1}
  </pre>
*  Vaya al swagger de la api e invoke el unico endpoint existente y mire como fluyen los eventos del servidor al cliente insomnia 

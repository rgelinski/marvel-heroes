# marvel-heroes

Este repositório tem por finalidade expor um exemplo de código, construído com .NET CORE 3.1,
a partir do template de exemplo de serviço em container Kubernetes disponibilizado no Visual Studio.


Para executar é necessário instalar o orquestrador Docker Desktop, ou outro similar.

O serviço serve como modelo de implementação para serviço de API.

Endpoints a serem implementados:

/v1/public/characters

/v1/public/characters/{characterId}

/v1/public/characters/{characterId}/comics

/v1/public/characters/{characterId}/events

/v1/public/characters/{characterId}/series

/v1/public/characters/{characterId}/stories

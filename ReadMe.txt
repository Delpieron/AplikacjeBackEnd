https://dirask.com/posts/WSEI-2021-2022-lato-labN-2-PROGN-Programowanie-aplikacji-back-endowych-labs-konw-jQk38D

Projekt StoreApi, pozwala na 



version: '3.4'

services:
  storeapi:
    image: ${DOCKER_REGISTRY-}storeapi
    build:
      context: .
      dockerfile: StoreApi/Dockerfile
    ports:
        - 44324:443
    networks:
        - my-network
    environment:
        - API_URL=mail_api:5000

  mailsenderapi:
    image: ${DOCKER_REGISTRY-}mailsenderapi
    container_name: mail_api
    build:
      context: .
      dockerfile: MailSenderApi/Dockerfile
    ports:
      - "0.0.0.0:5555:5000"
    networks:
        - my-network

networks:
  my-network:
    external: true
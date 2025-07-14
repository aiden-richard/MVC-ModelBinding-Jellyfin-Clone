# MVC-ModelBinding-Jellyfin-Clone

This project is a simple clone of the first two steps of the [Jellyfin](https://jellyfin.org/) setup process. Source Code here: [Jellyfin GitHub](https://github.com/jellyfin/jellyfin). Jellyfin is a free, open-source, and self-hosted media server that lets you stream content you own to all of your devices. It is built on the .NET platform.

The first two steps of the setup are: 
  1. Create an admin user
  2. Add a library to your server

## Example
You can quickly see what this process looks like by running the docker compose which is located in the [example-jellyfin](./example-jellyfin) folder.
```
services:
  jellyfin:
    image: jellyfin/jellyfin
    container_name: jellyfin
    volumes:
      - ./config:/config
      - ./cache:/cache
    ports:
      - 8096:8096
    restart: no
```
To start the server:
  1. make sure you're in the [example-jellyfin](example-jelyfin) folder
  2. run: `docker compose up -d`
  3. go to `http://localhost:8096/`

To stop the server, run: `docker compose down`
To reset the example, run: `reset-example.bat`

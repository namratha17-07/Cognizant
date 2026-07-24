# Docker Commands

## Check Docker Version

```bash
docker --version
```

---

## Display Docker Information

```bash
docker info
```

---

## Download an Image

```bash
docker pull ubuntu
```

---

## List Images

```bash
docker images
```

---

## Run a Container

```bash
docker run ubuntu
```

---

## Run Interactive Container

```bash
docker run -it ubuntu
```

---

## List Running Containers

```bash
docker ps
```

---

## List All Containers

```bash
docker ps -a
```

---

## Stop a Container

```bash
docker stop <container_id>
```

---

## Remove a Container

```bash
docker rm <container_id>
```

---

## Remove an Image

```bash
docker rmi <image_name>
```

---

## Build an Image

```bash
docker build -t myapp .
```

---

## Run a Custom Image

```bash
docker run myapp
```

---

## View Container Logs

```bash
docker logs <container_id>
```

---

## Execute Commands Inside a Container

```bash
docker exec -it <container_id> bash
```

---

## Pull hello-world Image

```bash
docker pull hello-world
```

---

## Run hello-world Container

```bash
docker run hello-world
```

---

## Docker Compose

Start services

```bash
docker compose up
```

Stop services

```bash
docker compose down
```
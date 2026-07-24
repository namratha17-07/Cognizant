# Learning Notes

## What is Containerization?

Containerization is a method of packaging an application along with all its dependencies so that it can run consistently across different environments.

---

## What is Docker?

Docker is an open-source platform used to build, package, distribute, and run applications inside lightweight containers.

---

## Why Docker?

- Lightweight
- Fast deployment
- Portable
- Consistent environments
- Easy scalability
- Efficient resource usage

---

## Docker Architecture

Docker consists of:

- Docker Client
- Docker Daemon
- Docker Engine
- Docker Registry (Docker Hub)
- Docker Images
- Docker Containers

---

## Docker Image

A Docker Image is a read-only template used to create containers.

Images contain:

- Application
- Runtime
- Libraries
- Dependencies
- Configuration

---

## Docker Container

A Docker Container is a running instance of a Docker Image.

Containers are:

- Lightweight
- Isolated
- Portable
- Easy to start and stop

---

## Docker Hub

Docker Hub is the official cloud repository where Docker Images are stored and shared.

---

## Dockerfile

A Dockerfile is a text file containing instructions to automatically build a Docker Image.

Common instructions include:

- FROM
- WORKDIR
- COPY
- RUN
- EXPOSE
- CMD

---

## Docker Compose

Docker Compose is used to define and manage multi-container applications using a YAML file.

Advantages:

- Easy service management
- One command to start multiple containers
- Better project organization

---

## Docker Volumes

Volumes are used to store persistent data outside the container.

Benefits:

- Data persistence
- Easy backup
- Shared storage

---

## Docker Networks

Docker Networks allow containers to communicate securely.

Common types:

- Bridge
- Host
- None

---

## Benefits of Docker

- Faster deployments
- Consistent development environment
- Easy scaling
- Isolation
- Better resource utilization

---

## Summary

Docker simplifies application deployment by packaging applications and their dependencies into lightweight, portable containers.
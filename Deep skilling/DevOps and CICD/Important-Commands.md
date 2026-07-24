# Important Commands

## Git Commands

Clone repository

```bash
git clone <repository-url>
```

Check status

```bash
git status
```

Stage files

```bash
git add .
```

Commit changes

```bash
git commit -m "Initial Commit"
```

Push changes

```bash
git push origin main
```

Pull latest changes

```bash
git pull
```

---

## GitHub Actions

Workflow directory

```
.github/workflows/
```

Workflow extension

```
.yml
```

---

## Azure DevOps

Login

```bash
az login
```

Show version

```bash
az version
```

---

## Docker (used in CI/CD)

Build image

```bash
docker build -t myapp .
```

Run container

```bash
docker run myapp
```

List containers

```bash
docker ps
```

List images

```bash
docker images
```

---

## Common Pipeline Stages

- Checkout
- Restore
- Build
- Test
- Publish
- Deploy
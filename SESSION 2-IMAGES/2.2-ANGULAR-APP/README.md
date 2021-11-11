# DOCKERFILE MULTI-STAGE BUILD EXAMPLE

## Build

```bash
$ docker build -t pqsar/angular-nginx-app-image:latest  .
```

## Use

```bash
docker run -d -p 8089:80 pqsar/angular-nginx-app-image:latest
```

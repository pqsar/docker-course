## STAGE 1: Build ###
FROM node:12.22.7-alpine AS build
WORKDIR /usr/src/app
COPY package.json package-lock.json ./
RUN npm install
COPY . .
RUN npm run build
### STAGE 2: Run ###
FROM nginx:1.21.3-alpine
COPY nginx.conf /etc/nginx/nginx.conf
# ver el outputPath en angular.json
COPY --from=build /usr/src/app/dist/ /usr/share/nginx/html
EXPOSE 80
ENTRYPOINT ["nginx", "-g", "daemon off;"]

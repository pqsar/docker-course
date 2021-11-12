FROM nginx:1.21.3-alpine
#COPY ./nginx.conf /etc/nginx/conf.d/default.conf
COPY ./host_app/ /usr/share/nginx/html/
EXPOSE 80
ENTRYPOINT ["nginx", "-g", "daemon off;"]
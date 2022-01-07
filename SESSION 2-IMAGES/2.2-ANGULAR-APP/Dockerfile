## STAGE 1: Build ###
FROM node:12.22.7-alpine AS build
WORKDIR /usr/src/app
COPY package.json package-lock.json ./
ADD ./uid_entrypoint.sh ./
ADD ./init.sh ./

RUN chown 1001:0 *.sh && chmod +wx *.sh
RUN chmod g=u /etc/passwd

USER 1001
ENTRYPOINT [ "./uid_entrypoint.sh" ]


CMD ["./init.sh"]


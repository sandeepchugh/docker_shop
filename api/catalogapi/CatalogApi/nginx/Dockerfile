FROM nginx:latest
VOLUME /var/cache/nginx

COPY ./config/nginx.conf /etc/nginx/nginx.conf

EXPOSE 80

ENTRYPOINT ["nginx"]
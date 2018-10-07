FROM alpine
COPY ./warmup .
RUN apk add --no-cache bash

CMD ["./wait-for-it.sh"]
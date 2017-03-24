#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>

#define PORT 8321
#define BACKLOG 1

int main() {
    int sockfd = socket(AF_INET, SOCK_STREAM, 0);
    if(sockfd == -1) {
        printf("create sockfd err\n");
        exit(1);
    }

    struct sockaddr_in server;
    bzero(&server, sizeof(server));
    server.sin_family = AF_INET;
    server.sin_port = htons(PORT);
    server.sin_addr.s_addr = htonl(INADDR_ANY);

    int ret = bind(sockfd, (struct sockaddr *)&server, sizeof(server));
    if(ret == -1) {
        printf("bind err\n");
        exit(1);
    }

    ret = listen(sockfd, BACKLOG);
    if(ret == -1) {
        printf("listen err\n");
        exit(1);
    }

    struct sockaddr_in client;
    socklen_t clientlen = sizeof(client);
    int connfd = accept(sockfd, (struct sockaddr *)&client, &clientlen);
    if(connfd == -1) {
        printf("accept err\n");
        exit(1);
    }
    printf("accept ok\n");

    sleep(30);

    return 0;
}

注：Dockerfile 支持以“#”开头的注释。
# FROM 
>指定 base 镜像。 
>eg: FROM busybox
# MAINTAINER
>设置镜像的作者，可以是任意字符串。
>eg: MAINTAINER justmine@qq.com
# WORKDIR
>为后面的 RUN, CMD, ENTRYPOINT, ADD 或 COPY 指令设置镜像中的当前工作目录。
>eg: WORKDIR /testDir
# RUN
>在容器中运行指定的命令。
>eg: RUN touch tmpfile1
# COPY
>将文件从 build context 复制到镜像。
>COPY 支持两种形式，注意：src 只能指定 build context 中的文件或目录。
>1、COPY src dest
>2、COPY ["src", "dest"]
>eg: COPY ["tmpfile2","."]
# ADD
>与 COPY 类似，从 build context 复制文件到镜像。不同的是，如果 src 是归档文件（tar, zip, tgz, xz 等），文件会被自动解压到 dest。
>eg: ADD ["bunch.tar.gz","."]
# ENV WELCOME "welcome you!"
>设置环境变量，环境变量可被后面的指令使用。
>eg: 
# EXPOSE
>指定容器中的进程监听某个端口，然后Docker将该端口暴露出来。
>eg: 
# VOLUME
>将文件或目录声明为 volume。
>eg: 
# CMD
>容器启动时运行指定的命令。
>Dockerfile 中可以有多个 CMD 指令，但只有最后一个生效。CMD 可以被 docker run 之后的参数替换。
>eg: 
# ENTRYPOINT
>设置容器启动时运行的命令。
>Dockerfile 中可以有多个 ENTRYPOINT 指令，但只有最后一个生效。CMD 或 docker run 之后的参数会被当做参数传递给 ENTRYPOINT。
>eg: 
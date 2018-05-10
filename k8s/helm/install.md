# client
curl https://raw.githubusercontent.com/kubernetes/helm/master/scripts/get | bash

# 安装 helm 的 bash 命令补全脚本
helm completion bash > .helmrcecho "source .helmrc" >> .bashrc

# 服务器
helm init


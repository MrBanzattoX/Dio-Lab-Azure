# Dio-Lab-Azure
# ☁️ Projeto Cloud Native com Python no Microsoft Azure

Este repositório apresenta uma aplicação Python (FastAPI) empacotada com Docker
e implantada em um cluster Kubernetes (AKS), utilizando CI/CD via GitHub Actions
para entrega contínua no Microsoft Azure.

---

## 🚀 Visão Geral do Projeto

Durante o curso **Microsoft Azure Cloud Native**, desenvolvi este projeto para aplicar os principais conceitos aprendidos:

- Contêineres com Docker
- Kubernetes com AKS (Azure Kubernetes Service)
- Registro de Imagens com ACR (Azure Container Registry)
- Integração e entrega contínua (CI/CD) com GitHub Actions
- Microsserviços com Python (FastAPI)

### ☸️ Aplicação rodando no AKS

![aks running](prints/aks-running.png)

### 📦 GitHub Actions CI/CD funcionando

![ci cd](prints/github-actions.png)

> *Você pode adicionar essas imagens na pasta `/prints` do projeto e substituí-las conforme seus próprios prints.*

---

## 🧠 O que Aprendi

Durante a construção deste projeto, entendi melhor:

- Como empacotar e publicar imagens Docker no Azure.
- Como criar e gerenciar serviços no AKS com `kubectl`.
- Como configurar um pipeline de CI/CD com segurança utilizando **GitHub Secrets**.
- A importância da observabilidade e logs para rastrear problemas em produção.
- Como um código simples em Python pode ser escalado em um ambiente robusto como o Azure.

---

## 📈 Possibilidades Futuras

- Integrar um banco de dados (Cosmos DB ou PostgreSQL no Azure).
- Criar testes automatizados antes do deploy.
- Adicionar monitoramento com Azure Monitor + Application Insights.
- Transformar essa API em um serviço para consumo de dados externos.

---

## 🧰 Tecnologias Utilizadas

- Python + FastAPI
- Docker
- Azure Container Registry
- GitHub Actions (CI/CD)
- Azure CLI / Portal


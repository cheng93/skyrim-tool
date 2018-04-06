#!/bin/bash

if [ "$TRAVIS_BRANCH" == "develop" ]
then
    docker login -u="$DOCKER_USERNAME" -p="$DOCKER_PASSWORD" $DOCKER_REGISTRY;
    docker tag skyrim-tool $DOCKER_REPO/skyrim-tool:dev;
    docker push $DOCKER_REPO/skyrim-tool:dev;
elif [ "$TRAVIS_BRANCH" == "master" ]
then
    docker login -u="$DOCKER_USERNAME" -p="$DOCKER_PASSWORD" $DOCKER_REGISTRY;
    docker tag skyrim-tool $DOCKER_REPO/skyrim-tool:latest;
    docker push $DOCKER_REPO/skyrim-tool:latest;
elif [[ "$TRAVIS_BRANCH" == release/* ]]
then 
    docker login -u="$DOCKER_USERNAME" -p="$DOCKER_PASSWORD" $DOCKER_REGISTRY;
    docker tag skyrim-tool $DOCKER_REPO/skyrim-tool:${TRAVIS_BRANCH:8};
    docker push $DOCKER_REPO/skyrim-tool:${TRAVIS_BRANCH:8};
elif [[ "$TRAVIS_BRANCH" == hotfix/* ]]
then 
    docker login -u="$DOCKER_USERNAME" -p="$DOCKER_PASSWORD" $DOCKER_REGISTRY;
    docker tag skyrim-tool $DOCKER_REPO/skyrim-tool:${TRAVIS_BRANCH:7};
    docker push $DOCKER_REPO/skyrim-tool:${TRAVIS_BRANCH:7};
fi
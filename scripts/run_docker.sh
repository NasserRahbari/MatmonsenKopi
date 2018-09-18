REGION=eu-central-1
REPOSITORY_NAME=ndla
REPOSITORY_URI=028339193837.dkr.ecr.$REGION.amazonaws.com/$REPOSITORY_NAME
COMMIT_HASH=$(echo $CODEBUILD_RESOLVED_SOURCE_VERSION | cut -c 1-7)
IMAGE_TAG=${COMMIT_HASH:=latest}

echo 'Login to registry'
eval "$(aws ecr get-login --region $REGION)"

docker stop $REPOSITORY_NAME || true
docker rm -f $REPOSITORY_NAME -f || true


docker pull $REPOSITORY_URI:$IMAGE_TAG
docker run -d --name $REPOSITORY_NAME -p 80:80 $REPOSITORY_URI:$IMAGE_TAG
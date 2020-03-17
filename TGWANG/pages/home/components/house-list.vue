<template>
	<view class="rice">
		<view class="sider">
			<view>
				<image :src="value.imgHeader" class="imgf"></image>
			</view>
			<view class="condition">
				<view class="one">
					<view class="tags">
						在售
					</view>
					<view class="name">{{value.floorName}}</view>
				</view>
				<view class="two">
					<view class="local">{{value.address}}</view>
					<view class="square">
						建面{{value.area}}㎡
					</view>
				</view>
				<view class="three">
					<view class="rices">
						{{value.floorPrice}}元/㎡起
					</view>
				</view>
				<view class="four">
					<view class="tips">
						<view v-for="(item,index) of tagsItem" :key="index" :class="ast[index]">{{item}}</view>
					</view>
				</view>
			</view>
		</view>
	</view>
</template>

<script>
	export default {
		props: {
			value: {
				type: Object,
				default: {}
			}
		},
		data() {
			return {
				tagsItem: []
			}
		},
		computed: {},
		mounted() {
			this.tagsItem = this.value.tags.replace(' ', '').replace(/'/g, '').replace('[', '').replace(']', '').split(',');
		},
	}
</script>

<style lang="less">
	.rice {
		height: 260upx;
		// padding: 40upx 0upx;
		display: flex;

		.sider {
			width: 100%;
			height: 260upx;
			height: 100%;
			display: flex;
			align-items: center;
			justify-content: space-between;
			flex-direction: row;

			.imgf {
				width: 200upx;
				height: 180upx;
				border-radius: 2px;
			}


			.condition {
				height: 200upx;
				width: 100%;
				margin-left: 30upx;
				display: flex;
				flex-flow: column;

				.one {
					display: flex;
					flex-direction: row;
					align-items: center;

					.tags {
						font-size: 24upx;
						color: #FFFFFF;
						text-align: center;
						margin-right: 14upx;
						line-height: 40upx;
						background: -webkit-linear-gradient(0deg, #6786d3, #3e59bc);
					}

					.name {
						font-weight: 700;
						font-size: 36upx;
					}
				}

				.two {
					display: flex;
					flex-direction: row;
					margin: 9upx 0upx;

					.local {
						font-size: 24upx;
					}

					.square {
						font-size: 24upx;
						margin-left: 24upx;
					}
				}

				.three {
					margin: 9upx 0upx;
					display: flex;
					flex-direction: row;

					.rices {
						color: red;
						font-weight: 700;
					}
				}

				.four {
					display: flex;
					flex-direction: row;
					height: 36upx;

					.tips {
						height: 36upx;

						view {
							margin-right: 10upx;
							font-size: 24upx;
							color: #979b9e;
							border: 1px solid #eaeaea;
						}
					}
				}
			}
		}
	}
</style>

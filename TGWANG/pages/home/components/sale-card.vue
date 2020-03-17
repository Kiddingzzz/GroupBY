<template>
	<view class="ab">
		<view class="gg">预售证书<view class="ggf">渝住建委（2019）预字第（2135）号</view></view>
		<view>发证时间：2019-12-24</view>
		<view>绑定楼栋：1幢</view>
	</view>
</template>

<script>
	export default{
		props:{
			value:{
				type:Object,
				default:{}
			}
		},
		computed:{},
		mounted() {
			
		},
	}
</script>

<style lang="less">
	.ab{
		line-height: 26px;
		font-size: 13px;
		margin-bottom: 15px;
		
		.gg{
			color: #666666;
			
			.ggf{
				color: #000;
			}
		}
		
	}
</style>

<template>
	<view class="cu-dialog">
		<view class="cu-bar bg-white justify-end">
			<view class="content">编辑地址</view>
			<view class="action" @tap="hideModal">
				<text class="cuIcon-close text-red"></text>
			</view>
		</view>
		<view >
			<form>
				<view class="cu-form-group">
					<view class="title">收货人</view>
					<input placeholder="收货人姓名" name="input" :value="_name" @input="inputChange"></input>
				</view>
				<view class="cu-form-group">
					<view class="title">手机号码</view>
					<input placeholder="收货人手机号" name="input" :value="_tel" @input="inputChange"></input>
				</view>
				
				<view class="cu-form-group">
					<view class="title">地区</view>
					<picker mode="region" @change="RegionChange" :value="_region">
						<view class="picker" style="text-align: left;">
							{{_region[0]}}，{{_region[1]}}，{{_region[2]}}
						</view>
					</picker>
				</view>
				
				<view class="cu-form-group">
					<view class="title">详细地址</view>
					<input placeholder="如街道,小区,乡镇,村" name="input" :value="_address" @input="inputChange"></input>
				</view>				
			</form>	
		</view>
		<view class="cu-bar bg-white justify-end">
			<view class="action">
				<button class="cu-btn line-green text-green" @tap="hideModal">取消</button>
				<button class="cu-btn bg-green margin-left" @tap="hideModal">确定</button>	
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
				isShow: false,
				// name: this.toChild.name,
				// tel: this.toChild.tel,
				// region: this.toChild.quyu,	
				// address: this.toChild.address,				
			};
		},
		computed:{
			_name(){
				return this.value.name ? this.value.name : ''
			},
			_tel(){
				return this.value.tel ? this.value.tel : ''
			},
			_region(){
				return this.value.quyu ? this.value.quyu : ['北京市', '广州市', '东城区']
			},
			_address(){
				return this.value.address ? this.value.address : ''
			}
		},
		methods:{
			hideModal(e) {				
				this.$emit('hideModalfun',this.isShow)
				this.$emit('hideModal',this.isShow)
			},	
			RegionChange(e) {
				this.region = e.detail.value
			},
			inputChange(){
				 
			}
		},
		
	
	}
</script>

<style>
	.cu-form-group .title {
		min-width: calc(4em + 15px);
	}
	.cu-form-group input{
		text-align: left;
	}
</style>

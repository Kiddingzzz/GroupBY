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
					<input placeholder="收货人姓名" name="input" v-model="value.recePeople" @input="inputChange"></input>
				</view>
				<view class="cu-form-group">
					<view class="title">手机号码</view>
					<input placeholder="收货人手机号" name="input" v-model="value.receTel" @input="inputChange"></input>
				</view>
				
				<view class="cu-form-group">
					<view class="title">地区</view>
					<picker mode="region" @change="RegionChange" v-model="value.adress">
						<view class="picker" style="text-align: left;">
							{{value.adress[0]}}，{{value.adress[1]}}，{{value.adress[2]}}
						</view>
					</picker>
				</view>
				
				<view class="cu-form-group">
					<view class="title">详细地址</view>
					<input placeholder="如街道,小区,乡镇,村" name="input" v-model="value.detAdress" @input="inputChange"></input>
				</view>				
			</form>	
		</view>
		<view class="cu-bar bg-white justify-end">
			<view class="action">
				<button class="cu-btn line-green text-green" @click="hideclose">取消</button>
				<button class="cu-btn bg-green margin-left" @click="hideModal">确定</button>	
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
				IsupOrAd:null,
			};
		},
		computed:{
			_recePeople(){
				
				this.IsupOrAd=this.value ;
				return this.IsupOrAd
			}
		},
		methods:{
			hideModal(e) {
				if(this.IsupOrAd=={})
				    this.$emit('hideModal',this.value);
				else
				    this.$emit('hideModalfun',this.value);
			},	
			hideclose(e){
				console.log("222")
				console.log(JSON.stringify(this.IsupOrAd))
				console.log("333")
				if(this.IsupOrAd=={})
				    this.$emit('hideModal',this.isShow);
				else
				    this.$emit('hideModalfun',this.isShow);
			},
			RegionChange(e) {
				this.value.adress = e.detail.value
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

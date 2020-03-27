<template>
	<view class="address">
		<address-list v-for="(item, index) of addressList" :value="item" :key="index" @DeleteValue="getMSD"></address-list>
		<view class="padding flex flex-direction">
			<button class="cu-btn bg-red margin-tb-sm lg" @tap="showModal">添加地址</button>
		</view>
		<view class="cu-modal show" v-show="isShow">
			<model-address @hideModal="getHideModal"></model-address>
		</view>
	</view>
</template>

<script>
	import addressList from '@/pages/center/myaddress/components/address-list.vue';
	import modelAddress from '@/pages/center/myaddress/components/model-address.vue';
	export default {
		components: {
			addressList,
			modelAddress
		},
		data() {
			return {
				isShow: false,
				addressList: [
					// { isDefault: true, name: '小红', tel: '13500874592', quyu: 	, address: '某街道某小区a栋4-2' },
					// { isDefault: false, name: '小明', tel: '13500874592', quyu: ['广东省', '广州市', '海珠区'], address: '某街道某小区a栋4-2' },
					// { isDefault: false, name: '收货人', tel: '13500874592', quyu: ['广东省', '广州市', '海珠区'], address: '某街道某小区a栋4-2' }
				]
			};
		},
		onLoad() {
			this.GetAdressList()
		},
		methods: {
			async getMSD(value) {
				this.GetAdressList();
			},

			async GetAdressList() {
				var res = await this.$http.get('api/cms/receAdressAppSerice/adressList' + '?userid=' +
					'0B1A1866-0BD3-72EB-25E5-39F3973F72EB')
				for (let i = 0; i < res.items.length; i++) {
					var ss = res.items[i].adress.split(',')
					res.items[i].adress = ss
				}
				this.addressList = res.items
				// var adresstxt=
				// var adress=adresstxt.split(',')
				// console.log(adress)
				console.log(this.addressList)

			},
			showModal() {
				this.isShow = true;
			},
			async getHideModal(data) {
				if (data == false) {
					this.isShow = false;
					return;
				} else {
					this.isShow = false;
					var adress = ''
					for (let i = 0; i < data.adress.length; i++) {
						if (adress == '')
							adress = data.adress[i];
						else
							adress = adress + ',' + data.adress[i];
					}
					const list = {
						recePeople: data.recePeople,
						receTel: data.receTel,
						adress: adress,
						detAdress: data.detAdress,
						defaultAdress: true,
						Userid: '0B1A1866-0BD3-72EB-25E5-39F3973F72EB'
					};
					await this.$http.post('api/cms/receAdressAppSerice/adress', list).then(res => {

						this.toast2Tapadd();
						this.GetAdressList();
					})
				}

			},
			toast2Tapadd: function() {
				uni.showToast({
					title: "添加成功",
					duration: 1500
				})
			},
		},
		computed: {}
	};
</script>

<style lang="less">
	.address {
		width: 100%;
		display: flex;
		flex-direction: column;

		.addresslist {
			display: flex;
			flex-direction: column;
			background: #fff;
			margin-bottom: 20upx;
			font-size: 24upx;

			.list {
				padding: 10upx 20upx;
			}
		}
	}
</style>
